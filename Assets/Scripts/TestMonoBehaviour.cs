using Sentry;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    private GameObject testObject = null;

    void Start()
    {
        //Debug.Log("Captured Log");              // Breadcrumb
        //Debug.LogWarning("Captured Warning");   // Breadcrumb
        //Debug.LogError("Captured Error");       // Captured Error
        //Debug.LogError("New Error");
        // This will throw a Null Reference Exception
        //testObject.GetComponent<Transform>();   // Captured error
    }

    public void OnClickErrorButton()
    {
        Debug.LogError("Error");
    }

    public void OnClickExceptionButton()
    {
        throw new System.Exception("Exception");
    }
}