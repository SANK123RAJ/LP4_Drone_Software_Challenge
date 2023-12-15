using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Action OnRoadPlacement, OnHousePlacement, OnSpecialPlacement,OnBigStructurePlacement,OnElectricHousePlacement,OnSchoolPlacement;
    public Button placeRoadButton, placeHouseButton, placeSpecialButton,placeBigStructureButton,placeElectricHouseStructureButton,placeSchoolButton;

    public Color outlineColor;
    List<Button> buttonList;

    private void Start()
    {
        buttonList = new List<Button> { placeHouseButton, placeRoadButton, placeSpecialButton,placeBigStructureButton,placeSchoolButton,placeElectricHouseStructureButton };

        placeRoadButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeRoadButton);
            OnRoadPlacement?.Invoke();

        });
        placeHouseButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeHouseButton);
            OnHousePlacement?.Invoke();

        });
        placeSpecialButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSpecialButton);
            OnBigStructurePlacement?.Invoke();

        });
        placeBigStructureButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeBigStructureButton);
            OnSpecialPlacement?.Invoke();

        });
        placeSchoolButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeSchoolButton);
            OnSchoolPlacement?.Invoke();

        });
        placeElectricHouseStructureButton.onClick.AddListener(() =>
        {
            ResetButtonColor();
            ModifyOutline(placeElectricHouseStructureButton);
            OnElectricHousePlacement?.Invoke();

        });
       
    }

    private void ModifyOutline(Button button)
    {
        var outline = button.GetComponent<Outline>();
        outline.effectColor = outlineColor;
        outline.enabled = true;
    }

    private void ResetButtonColor()
    {
        foreach (Button button in buttonList)
        {
            button.GetComponent<Outline>().enabled = false;
        }
    }
}
