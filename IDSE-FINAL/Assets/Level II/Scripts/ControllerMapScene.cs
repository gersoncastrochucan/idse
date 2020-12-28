using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControllerMapScene : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ZoneScript> ListaZonas = new List<ZoneScript>();
    void Start()
    {
        UpdateZones();
    }
    public void UpdateZones()
    {
        for (int i = 0; i < ListaZonas.Count; i++)
        {
            ListaZonas[i].bloqueado = true;
        }
        for (int i = 0; i < GameSettings.Instance.NivelDesbloqueado; i++){
            ListaZonas[i].bloqueado = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                ZoneScript tempzone = hit.collider.gameObject.GetComponent<ZoneScript>();
                if (tempzone != null)
                    {
                    if (tempzone.pos == GameSettings.Instance.NivelDesbloqueado +1)
                    {
                        GameSettings.Instance.SetValueNivel(tempzone.pos);
                        UpdateZones();
                    }
                }
            }
        }
    }
}