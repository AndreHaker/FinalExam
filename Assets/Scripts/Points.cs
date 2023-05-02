using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text points;
    public Button decreasePoints;
    public Button increasePoints;
    public int pointsCounter;
    // Start is called before the first frame update
    void Start()
    {
        pointsCounter = 0;
        points.text = pointsCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void IncreasePoints()
    {
        pointsCounter += 1;
        points.text = pointsCounter.ToString();
    }

   public void DecreasePoints()
    {
        pointsCounter -= 1;
        points.text = pointsCounter.ToString();
    }
}
