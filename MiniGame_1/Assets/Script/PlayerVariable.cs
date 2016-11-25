using System.Collections;
using UnityEngine;

public class PlayerVariable : MonoBehaviour{

	public enum PlayerStatus
	{
		idle,move,attack,rest,dead
	}
	public PlayerStatus _playerStatus = PlayerStatus.idle;

	public float moveSpeed =5;
	public float attackSpeed =5;
	public float attackRestTime=5;


}
