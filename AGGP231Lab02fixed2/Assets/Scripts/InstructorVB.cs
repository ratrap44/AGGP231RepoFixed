using UnityEngine;
using Vuforia;

public class InstructorVB : MonoBehaviour, IVirtualButtonEventHandler
{

	public GameObject cube;
	public GameObject virtualButton;
	/// <summary>
	/// Called when the scene is loaded
	/// </summary>
	void Start()
	{

		virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

	}

	/// <summary>
	/// Called when the virtual button has just been pressed:
	/// </summary>
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{

		Debug.Log("button Pressed");

	}

	/// <summary>
	/// Called when the virtual button has just been released:
	/// </summary>
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

		Debug.Log("button Released");
	}
}