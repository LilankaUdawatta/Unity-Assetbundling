#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetBundling : MonoBehaviour {

	[MenuItem("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles()
	{
		//string assetBundleDirectory = "Assets/StreamingAssets/AssetBundles";
		BuildPipeline.BuildAssetBundles("Assets/StreamingAssets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
	}
}
#endif