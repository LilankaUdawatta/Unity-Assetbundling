﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.Networking;

public class LoadAssetBundleExample: MonoBehaviour
{

	string nameOfAssetBundle = "1";
	string nameOfObjectToLoad = "New Prefab";

	void Start()
	{
		StartCoroutine(loadAsset(nameOfAssetBundle, nameOfObjectToLoad));
	}

	IEnumerator loadAsset(string assetBundleName, string objectNameToLoad)
	{
		string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "AssetBundles");
		filePath = System.IO.Path.Combine(filePath, assetBundleName);

		var assetBundleCreateRequest = AssetBundle.LoadFromFileAsync(filePath);
		yield return assetBundleCreateRequest;

		AssetBundle asseBundle = assetBundleCreateRequest.assetBundle;

		AssetBundleRequest asset = asseBundle.LoadAssetAsync<GameObject>(objectNameToLoad);
		yield return asset;

		GameObject loadedAsset = asset.asset as GameObject;
		//Do something with the loaded loadedAsset  object
		//Instantiate(asseBundle.mainAsset);
		
		Instantiate(asseBundle.LoadAsset(nameOfObjectToLoad));
		
	}
}
