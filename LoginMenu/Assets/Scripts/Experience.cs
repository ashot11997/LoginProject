using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experience : MonoBehaviour
{
	public Button SpawnButton;
	public Button GetButton;

	public Transform SpawnContainer;
	public GameObject PointPrefab;
	public GameObject YourPoint;

	private List<GameObject> AllPoints = new List<GameObject>();

	void Awake() {
		SpawnButton.onClick.AddListener(Spawn);
		GetButton.onClick.AddListener(FindNearestPoint);
	}

	public void Clear() {
		AllPoints.Clear();
		foreach (Transform SpawnedItems in SpawnContainer)
		{
			if (SpawnedItems.name != "You")
			{
				Destroy(SpawnedItems.gameObject);
			}
		}
	}

	void FindNearestPoint() {
		float distance = Mathf.Infinity;
		GameObject NearesPoint = null;

		foreach (GameObject point in AllPoints)
		{
			float distanceToPoint = (point.GetComponent<RectTransform>().position - YourPoint.GetComponent<RectTransform>().position).sqrMagnitude;

			if (distanceToPoint < distance)
			{
				distance = distanceToPoint;
				NearesPoint = point;
			}
		}


		NearesPoint.GetComponent<Image>().color = new Color32(50, 205, 50, 255);
		NearesPoint.GetComponent<RectTransform>().localScale = new Vector3(1.2f, 1.2f, 1.2f);
	}

	void Spawn() {
		AllPoints.Clear();
		foreach (Transform SpawnedItems in SpawnContainer)
		{
			if (SpawnedItems.name != "You")
			{
				Destroy(SpawnedItems.gameObject);
			}
		}

		for (int i = 0; i < 4; i++)
		{
			var Point = Instantiate(PointPrefab, SpawnContainer);
			var x = Random.Range(-385.99f, 385.99f);
			var y = Random.Range(310, -310);
			Point.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
			AllPoints.Add(Point);
		}
	}
}
