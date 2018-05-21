using UnityEngine;


/// <summary>
/// 物体自转
/// </summary>
public class ChinarRotation : MonoBehaviour
{
    public float Speed = 15f; //自转速率


    void Update()
    {
        transform.Rotate(Vector3.up, Speed * Time.deltaTime);
    }
}