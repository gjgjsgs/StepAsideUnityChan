using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    private GameObject unitychan;

    public GameObject carPrefab;

    public GameObject coinPrefab;

    public GameObject conePrefab;

    private int startPos = -230;

    private int nextPos = 50;

    private int count = 0;

    private float posRange = 3.4f;

    

    // Use this for initialization
    void Start () {


        this.unitychan = GameObject.Find("unitychan");

        randomitem();

       
	}
	
	// Update is called once per frame
	void Update () {

        for (int m = 0; m < 5; m++)
        {



            if (startPos + nextPos < unitychan.transform.position.z && count == m)
            {
                randomitem();

                Debug.Log("実行している" + m + "  time");

                count += 1;

                nextPos += 60;
            }


        }

    }

    void randomitem()
    {
        for (float i = unitychan.transform.position.z + 20; i < unitychan.transform.position.z + 70; i += 10)
        {

            int num = Random.Range(1, 11);

            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);

                    int offsetZ = Random.Range(-5, 6);

                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;

                        coin.transform.position = new Vector3(posRange = j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;

                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }

            }

        }

    }

}
