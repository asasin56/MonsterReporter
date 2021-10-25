using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMethods : MonoBehaviour
{
 public void Load(int sceneId) => SceneManager.LoadScene(sceneId);

 public void OpenLink(string url) => Application.OpenURL(url);
 public void Exit() => Application.Quit();
}
