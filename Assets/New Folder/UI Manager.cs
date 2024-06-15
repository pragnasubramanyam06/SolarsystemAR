using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject LoadingPanel;


    // Start is called before the first frame update
    void Start()
    {
        LoadingPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        
    }

    IEnumerator DelaySceneLoad()
    {
        LoadingPanel.SetActive(true);
        MenuPanel.SetActive(false);
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);


    }
    public void ExploreArCall()
    {
        StartCoroutine(DelaySceneLoad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
