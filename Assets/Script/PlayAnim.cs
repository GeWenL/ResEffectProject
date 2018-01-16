using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour {
	public Transform startImg;
	public Transform endImg;
	public GameObject prefab;
	public GameObject gameObjectPool;
	public ResEffect resEffect;
	// Use this for initialization
	void Start () {
		// public void Init(GameObject _gameObjectPool, List<GameObject> prefabList)
		List<GameObject> list = new List<GameObject>();
		list.Add (prefab);
		gameObjectPool.SetActive(false);
		prefab.SetActive(false);
		resEffect.Init (gameObjectPool,  list);
	}



	public void Play () {
		// public float Play(int type, Vector3 source, Vector3 target, int count, System.Action<int> onFinish)
		resEffect.Play (0, startImg.position, endImg.position, Random.Range(3, 100), (int num)=>{
			if (num == 0) 
			{
				Debug.Log("======》第一个资源icon飞到资源栏");
			}
			else if (num == 1)
			{
				Debug.Log("======》最后一个资源icon飞到资源栏");
			}
		});
	}

}
