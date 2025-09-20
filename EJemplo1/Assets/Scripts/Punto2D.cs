using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelMouseTracker : MonoBehaviour, IPointerMoveHandler
{
    private RectTransform panelRectTransform;

    void Start()
    {
        // Obtener el componente RectTransform del panel
        panelRectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // Convertir las coordenadas del cursor (en píxeles de pantalla) a coordenadas locales dentro del panel
        Vector2 localCursor;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            panelRectTransform,
            eventData.position, // Posición del cursor en píxeles de pantalla
            eventData.pressEventCamera, // Cámara del Canvas (puede ser null para Canvas en Overlay)
            out localCursor