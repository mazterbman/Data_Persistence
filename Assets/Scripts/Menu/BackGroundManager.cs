using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundManager : MonoBehaviour
{
    [SerializeField] float timeLerp;
    [SerializeField] Vector2 startPos = Vector2.zero;

    float diff = 200;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            startPos = new Vector2(startPos.x + diff, 0);

            InfoForLerp info = new InfoForLerp();
            info.obj = transform.GetChild(i).gameObject;
            info.endPos = new Vector2(startPos.x, 0);
            info.timeLerp = timeLerp;

            StartCoroutine(changePosLerp(info));
        }
    }

    IEnumerator changePosLerp(InfoForLerp info)
    {
        Vector2 startPos = info.obj.GetComponent<RectTransform>().anchoredPosition;
        float time = 0;

        while (time < info.timeLerp)
        {
            yield return null;
            info.obj.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPos, info.endPos, time / timeLerp);
            time += Time.deltaTime;
        }

        info.obj.GetComponent<RectTransform>().anchoredPosition = info.endPos;
    }

    class InfoForLerp
    {
        public Vector2 endPos;
        public float timeLerp;
        public GameObject obj;
    }
}
