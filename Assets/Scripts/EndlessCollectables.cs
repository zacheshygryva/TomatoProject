using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessCollectables : MonoBehaviour {
    public GameObject repeat_prefab;
	protected GameObject[] obstacles;
	protected int current = 0;

    public float speed = 3f;
	public int obstacles_num = 5;

	protected Vector2 position = new Vector2 (-15,-25);
	protected float apper_hor = 10f;
	public float pos_min = -1f;
    public float pos_max = 3.5f;

	protected float Wait;

	public float offset = 1.0f;

	void Awake() {
        Wait += offset;
    }

    void Start() {
        Wait = 0f;
        obstacles = new GameObject[obstacles_num];
        for(int i = 0; i < obstacles_num; i++)
            obstacles[i] = (GameObject)Instantiate(repeat_prefab, position, Quaternion.identity);
    }

    void FixedUpdate() {
        Wait += Time.deltaTime;
        if (LevelController.instance.gameOver == false && Wait >= speed) {   
            Wait = 0f;
            float apper_ver = Random.Range(pos_min, pos_max);
            obstacles[current].transform.position = new Vector2(apper_hor, apper_ver);
            current ++;
            if (current >= obstacles_num) current = 0;
        }
    }
}