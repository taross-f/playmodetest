using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class NewPlayModeTest {

	[Test]
	public void NewPlayModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	[SetUp]
	public void SetUp()
	{
		Debug.logger.logEnabled = false;
	}
	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator NewPlayModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		SceneManager.LoadScene("Test1", LoadSceneMode.Additive);
		yield return null;
		var cube = GameObject.Find("Cube");
		Assert.IsNotNull(cube);
		yield return null;
		LogAssert.NoUnexpectedReceived();
	}

	[Test]
	public void LogAssertEample()
	{
	}
}
