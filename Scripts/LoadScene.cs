using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
   public int scene;  // индекс загружаемой сцены по умолчанию, который в редакторе можно изменить

void Update()
{
 if(Input.GetKey(KeyCode.V))
       {
           SceneManager.LoadScene(scene);
           Saving.level++;
           Saving.Save();
       }
}
}