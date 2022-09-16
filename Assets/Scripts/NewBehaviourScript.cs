using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacebarGameManager : MonoBehaviour
{
    private TMPro.TextMeshProUGUI score;


    // Start is called before the first frame update
    private void Start()
    {
        score = this.GetComponent<TMPro.TextMeshProUGUI>();

    }

    // Update is called once per frame
    private void Update()
    {
        score.text = Mathf.Floor(Time.time).ToString();
    }
}
