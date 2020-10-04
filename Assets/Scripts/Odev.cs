using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Odev : MonoBehaviour
    {

         void Start()
        {
        Debug.Log("konsola yazılıyor");
        Execute();
        }
        
        public void Execute()
        {
            //PlayerController pc = new PlayerController();
            Debug.Log("konsola yazılıyor");
        }

        public void Exit()
        {

        }

    

    public class PlayerController
    {
        private int _hp = 100;
        private int _currentHp;

        private static PlayerController _attack1;

        private PlayerController() { }

        public static PlayerController GetAttack()
        {
            if (_attack1 == null)
                _attack1 = new PlayerController();

            return _attack1;
        }

        public void Start()
        {
            _currentHp = _hp;
            //GameManager.Get().StartCoroutine(FakeUpdate(0.2f));
        }

        private IEnumerator FakeUpdate(float period)
        {
            WaitForSeconds waitPeriod = new WaitForSeconds(period);

            while (true)
            {
                GetInput();
                EnemyAttack();
                Die();

                yield return waitPeriod;
            }
        }

        private void GetInput()
        {
            Debug.Log("Getting Input");
        }

        private void EnemyAttack()
        {
            if ( _attack1 != null)
                Debug.Log("You've been attacked");
        }

        private void Die()
        {
            if(_currentHp <= 0 ) Debug.Log("You just died");
        }
    }

}
