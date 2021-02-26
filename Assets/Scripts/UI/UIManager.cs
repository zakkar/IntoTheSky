using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //Load GameLevelScene
    public void LoadGame()
    {
        SceneManager.LoadScene("GameLevelScene");
    }

    //Load ShopScene
    public void LoadShop()
    {
        SceneManager.LoadScene("Shop1Scene");
    }

    //Load NoAdsScene
    public void LoadNoAds()
    {
        SceneManager.LoadScene("NoAdsScene");
    }

    //Load the next page
    public void NextPage()
    {
        SceneManager.LoadScene("Shop2Scene");
    }

    //Reload the previous page
    public void PreviousPage()
    {
        SceneManager.LoadScene("Shop1Scene");
    }

    //Exit the scene
    public void ExitScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    //Load Menu Scene
    public void HomePage()
    {
        SceneManager.LoadScene("MenuScene");
    }

    
}
