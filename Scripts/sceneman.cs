using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneman : MonoBehaviour
{
   public int scene;  // индекс загружаемой сцены по умолчанию, который в редакторе можно изменить

   void Start()
   {
      Saving.Save();
   }

public void Load()
{
   SceneManager.LoadScene(scene);
}
}