using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class Vision : MonoBehaviour
{
    //
    public Transform Player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;
    bool follow = false;
    //

    [SerializeField]
    [TextArea(5, 20)]
    private string Descripcion = " ";


    public float Radio = 10;
    [Range(0, 360)]
    public float Vicion = 120;

    public LayerMask Jugador;
    public LayerMask Obstaculos;

    [HideInInspector]
    public List<Transform> JugadoresVisible = new List<Transform>();

    void Start()
    {
        StartCoroutine("FindTargetsWithDelay", .2f);
    }

    void Update()
    {
        if (follow == true)
        {
            transform.LookAt(Player);
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            }
        }
    }


    IEnumerator FindTargetsWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            EncontratJugadoresVisible();
        }
    }

    void EncontratJugadoresVisible()
    {
        JugadoresVisible.Clear();
        Collider[] targetsInRadio = Physics.OverlapSphere(transform.position, Radio, Jugador);

        for (int i = 0; i < targetsInRadio.Length; i++)
        {
            Transform target = targetsInRadio[i].transform;
            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToTarget) < Vicion / 2)
            {
                float dstToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, dirToTarget, dstToTarget, Obstaculos))
                {
                    JugadoresVisible.Add(target); //CREA LINEA DE VIVION
                    Debug.Log("I see you");
                    follow = true;


                }
            }
        }
    }


    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}
