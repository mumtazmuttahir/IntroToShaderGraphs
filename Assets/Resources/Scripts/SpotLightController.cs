using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpotLightController : MonoBehaviour
{
    #region public_variables
    public GameObject SpotLight;
    #endregion

    #region private_variables
    private Light spotLightComponent;
    Color redColor = Color.red;
    Color greenColor = Color.green;
    Color blueColor = Color.blue;
    int lightNumber = -1;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //Get the light component from the gameobject
        spotLightComponent = SpotLight.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //For single button in the scene
    //Changes to green
    public void ChangeSpotLihgtToGreen () {
        spotLightComponent.color = greenColor;
    }
    //For single button in the scene
    //Changes to blue
    public void ChangeSpotLihgtToBlue () {
        spotLightComponent.color = blueColor;
    }
    //For single button in the scene
    //Changes to red
    public void ChangeSpotLihgtToRed () {
        spotLightComponent.color = redColor;
    }

    //For switch button in the scene
    //Changes to other colors sequentially
    public void ChangeColor () {
        if (lightNumber == -1) {
            spotLightComponent.color = redColor;
            lightNumber = 1;
        } 
        else if (lightNumber == 1) {
            spotLightComponent.color = greenColor;
            lightNumber++;
        }
        else if (lightNumber == 2) {
            spotLightComponent.color = blueColor;
            lightNumber = 0;
        }
        else if (lightNumber == 0) {
            spotLightComponent.color = redColor;
            lightNumber++;
        }
    }

}
