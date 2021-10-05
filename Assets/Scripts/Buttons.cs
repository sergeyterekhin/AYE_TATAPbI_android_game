using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
public Sprite layer_blue, layer_red;
public string applicat;
public GameObject m_on, m_off;
void OnMouseDown() {
GetComponent <SpriteRenderer> ().sprite=layer_red;
}

void start(){
  if (gameObject.name=="music"){
  if (PlayerPrefs.GetString("music")=="no")
  {
     m_on.SetActive(false);
   m_off.SetActive(true);  
  }
  else
  {
    m_on.SetActive(true);
   m_off.SetActive(false); 
  }
  }
}

void OnMouseUp() {
GetComponent <SpriteRenderer> ().sprite=layer_blue;
}

void OnMouseUpAsButton(){
  if (PlayerPrefs.GetString("music")!="no")
GameObject.Find("Click Audio").GetComponent <AudioSource> ().Play();
  switch (applicat){
   case "play":  Application.LoadLevel("StartGame"); break;
    case "settings": Application.OpenURL("https://vk.com/id488926074"); break;
    case "Replay": Application.LoadLevel("StartGame"); break;
    case "Home": Application.LoadLevel("Menu"); break;
    case "help": Application.LoadLevel("howTo"); break;
    case "exithelp": Application.LoadLevel("Menu"); break;
  case "music": if (PlayerPrefs.GetString("music")!="no")
  {
   PlayerPrefs.SetString("music","no");
   m_on.SetActive(false);
   m_off.SetActive(true);
  }
   else {
     PlayerPrefs.SetString("music","yes");
   m_on.SetActive(true);
   m_off.SetActive(false);
   }
   break;
  } 
}

}
