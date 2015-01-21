using UnityEngine;
using System.Collections;
//состояние переключателей
enum FlagAnimationToggle
{
	OFF = 0,        //состояние включено
	ON = 1  //состояние выключено
}

public class Toggle_1 : MonoBehaviour {
	
	FlagAnimationToggle AnimState_Toggle; //состояние анимации переключателя
	
	// Use this for initialization
	void Start () {
		AnimState_Toggle = FlagAnimationToggle.OFF;
	}
	
	// Update is called once per frame
	void Update () {
		//      Debug.Log("Animation!!!");      
		
		// process object selection
		if (Input.GetMouseButtonDown(0))
		{
			SelectObjectByMousePos();
			
		}
	}
	
	void SelectObjectByMousePos()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 10000, 1<<0)) //1<< 0, битная маска, говорит о том что коллизия с лучем, будет считатся только для нулевого слоя, а если например вот так 1<< 8, то для восьмого, и т.д.
		{
			
			if(AnimState_Toggle == FlagAnimationToggle.ON){
				//включаем обратную анимацию
				this.animation["Animation_Switch"].speed = -1;  // Изменяем последовательность анимации
				this.animation["Animation_Switch"].time = this.animation["Anim_Switch"].length; //Это для обратной анимации переключателя
				
				AnimState_Toggle = FlagAnimationToggle.OFF;
			}else{
				//включаем прямую анимацию
				this.animation["Animation_Switch"].speed = 1;   //изменяем последовательность амимации
				
				AnimState_Toggle = FlagAnimationToggle.ON;
			}
			this.animation.Play("Animation_Switch");                        
		}
	}
}

