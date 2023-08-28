using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // G‚ê‚½obj‚Ìe‚ğˆÚ“®°‚É‚·‚é
            other.transform.SetParent(transform);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // G‚ê‚½obj‚Ìe‚ğ‚È‚­‚·
            other.transform.SetParent(null);
        }
    }
}
