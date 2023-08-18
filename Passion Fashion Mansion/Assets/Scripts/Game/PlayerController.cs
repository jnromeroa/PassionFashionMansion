using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform movePoint;
    [SerializeField] float speed;
    [SerializeField] float distanceToMovePointTreshold = 0.05f;
    [SerializeField] float gridSize = 1f;
    [SerializeField] LayerMask unwalkableLayer;
    [SerializeField] LayerMask interactableLayer;
    PlayerInput pInput;
    Transform t;
    Vector2 input;
    Vector2 lastMovement;
    readonly string moveStr = "Move";
    private void Start()
    {
        pInput = GetComponent<PlayerInput>();
        movePoint.parent = null;
        t = transform;
    }
    private void Update()
    {
        input = pInput.actions[moveStr].ReadValue<Vector2>();
        MovePoint();
        Move();
    }

    public void MovePoint()
    {
        
        if ((t.position - movePoint.position).sqrMagnitude > distanceToMovePointTreshold * distanceToMovePointTreshold) return;
        if (Mathf.Abs(input.x) == 1f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(input.x * gridSize, 0f, 0f), 0.4f, unwalkableLayer))
            {
                movePoint.position += new Vector3(input.x * gridSize, 0f, 0f);

            }
            return;
        }
        if (Mathf.Abs(input.y) == 1f)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, input.y * gridSize, 0f), 0.4f, unwalkableLayer))
            {
                movePoint.position += new Vector3(0f, input.y * gridSize, 0f);
            }
        }
    }

    private void Move()
    {
        t.position = Vector2.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);
    }
    public void Interact()
    {
        Vector3 pointInFront = new Vector3(lastMovement.x * gridSize, lastMovement.y * gridSize, 0);
        Collider2D interactedWith = Physics2D.OverlapCircle(t.position +pointInFront , 0.4f, interactableLayer);
        if (interactedWith)
        {
            CheckInteractable(interactedWith);
            return;
        }
        pointInFront = new Vector3(lastMovement.x * gridSize * 2, lastMovement.y * gridSize * 2, 0);
        interactedWith = Physics2D.OverlapCircle(t.position + pointInFront, 0.4f, interactableLayer);
        if (!interactedWith) return;
        CheckInteractable(interactedWith);
    }
    void CheckInteractable(Collider2D interactedWith)
    {

    }
}
