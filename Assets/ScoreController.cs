using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	int score = 0;

	//スコアを表示するテキスト
	private GameObject scoreText;

	// Use this for initialization
	void Start () {

		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
		this.scoreText.GetComponent<Text> ().text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {

	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

		this.scoreText.GetComponent<Text> ().text = score.ToString();

		//変数の宣言
		int scoreLarge = 20;
		int scoreSmall = 10;

		// タグによってスコアを追加する
		if (other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "SmallCloudTag") {

			score += scoreLarge;
			Debug.Log ("10点");
		} 
		else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag") {

			score += scoreSmall;
			Debug.Log ("20点");
		}
	}
}