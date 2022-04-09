using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour {
    public float lookRadius = 10f;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    void Start() {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minY, maxY));

        int playerAvatarIndex = (int)PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"];
        PlayerPrefs.SetInt("PlayerAvatar", playerAvatarIndex);
        string prefabName = PlayerAvatars.Instance.GetPlayerAvatarsName(playerAvatarIndex);

        PhotonNetwork.Instantiate(prefabName, randomPosition, transform.rotation);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

}
