using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScroller : MonoBehaviour {

    public GameObject[] challenges;
    public float scrollSpeed = 10f;
    public Transform challengeSpawnPoint;

    public float counter = 0f;

	// Use this for initialization
	void Start () {
        GenerateChallenges();
	}

    void GenerateChallenges()
    {
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengeSpawnPoint.position, Quaternion.identity);
        newChallenge.transform.parent = transform;

        counter = 2f;
    }

    void ScrollChallenge(GameObject currChallenge)
    {
        currChallenge.transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter <= 0)
        {
            GenerateChallenges();
        }
        else
        {
            counter -= Time.deltaTime;
        }

        GameObject currChild;
        for(int i = 0; i <transform.childCount; i++)
        {
            currChild = transform.GetChild(i).gameObject;
            ScrollChallenge(currChild);
        }

    }
}
