using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _playerStartPosition = Vector3.zero;
    [SerializeField] private GameObject _menuUi;

    public void onStartPressed() {
        _player.SetActive(true);
        _player.transform.position = _playerStartPosition;
        _menuUi.SetActive(false);
    }
}
