using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTab : MonoBehaviour
{
    [SerializeField] private List<GameObject> panels;
    // Start is called before the first frame update
    void Start()
    {
        DisablePanels();
        panels[0].SetActive(true);
    }

    private void DisablePanels()
    {
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
    }

    public void SelectPanel(GameObject panel)
    {
        DisablePanels();
        panel.gameObject.SetActive(true);
    }
}
