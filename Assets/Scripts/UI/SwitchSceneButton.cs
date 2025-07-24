using UnityEngine;
using UnityEngine.SceneManagement; 
public class SwitchSceneButton : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SwitchSceneHerbarium()
    {
        SceneManager.LoadScene("nnHerbariumScene"); 
    }

    public void SwitchSceneTherapyNotes()
    {
        SceneManager.LoadScene("TherapyNotesScene"); 
    }
}
