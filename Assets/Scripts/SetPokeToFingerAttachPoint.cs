using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    [SerializeField] private Transform PokeAttachPoint;
    private XRPokeInteractor _xrPokeInteractor;

    private void Start() {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    private void SetPokeAttachPoint() {
        if (PokeAttachPoint == null) { Debug.Log("Poke Attach Point is null"); return; }
        if (_xrPokeInteractor == null) { Debug.Log("XR Poke Interactor is null"); return; }
        _xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}
