using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

//Menuバーからシーンを遷移する
public class SceneNavigation : Editor
{
    //Sceneを開く
    private static void OpenScene(int sceneIndex)
    {
        string scenePath = SceneUtility.GetScenePathByBuildIndex(sceneIndex);
        if (!string.IsNullOrEmpty(scenePath))
        {
            EditorSceneManager.OpenScene(scenePath);
        }
    }
}