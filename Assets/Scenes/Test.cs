using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp, mp, power;

	public Boss(){
		this.mp = 53;
	}

	public void Magic(){
		if(this.mp >= 5){
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは " + this.mp + " 。");
		} else {
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {1,2,3,4,5};
		// 順番に表示
		for(int i=0;i<5;i++){
			Debug.Log(array[i]);
		}
		// 逆順表示
		for(int i=0;i<5;i++){
			Debug.Log(array[4-i]);
		}

		Boss b = new Boss();
		for(int i=0; i<11; i++){
			b.Magic();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
