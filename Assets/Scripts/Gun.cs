using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TowerDefese
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private int _poolLength;
        [SerializeField] private float _timeBulletLife;
        [SerializeField] private Transform _muzzle;
        [SerializeField] private float _speed;
        [SerializeField] private float _rechargeTime;

        private bool _willingness = true;

        private GameObject[] _bullets;
        private void Start()
        {
            Init();
        }

        private void Init()
        {
            _bullets = new GameObject[_poolLength];
            for (int i = 0; i < _poolLength; i++)
            {
                _bullets[i] = Instantiate(_bulletPrefab);
                _bullets[i].SetActive(false);
            }
        }

        private IEnumerator Recharged(float time)
        {
            yield return new WaitForSeconds(time);
            _willingness = true;
        }

        private IEnumerator FlyBullet(GameObject bullet, float timeFly)
        {
            yield return new WaitForSeconds(timeFly);
            bullet.gameObject.SetActive(false);
        }

        public void Shot()
        {
            foreach (var bullet in _bullets)
            {
                if (!_willingness)
                    return;
                if (!bullet.activeInHierarchy)
                {
                    bullet.transform.position = _muzzle.position;
                    var rb = bullet.GetComponent<Rigidbody2D>();
                    bullet.SetActive(true);
                    rb.AddForce(transform.up * _speed);

                    StartCoroutine(FlyBullet(bullet, _timeBulletLife));
                    StartCoroutine(Recharged(_rechargeTime));
                    _willingness = false;
                    return;

                }
            }
        }
    }

}