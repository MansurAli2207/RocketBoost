using Unity.VisualScripting;
using UnityEngine;

public class ColllisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Everything is Good you Can fly");
                break;

            case "Finish":
                Debug.Log("Welcome to our Country you have landed properly");
                break;

            case "Fuel":
                Debug.Log("You Have Hitted Me am not in the Game");
                break;

            default:
                Debug.Log("You've Crashed");
                break;
        }
    }
}
