using System;
using CommandBuses;
using UnityEngine;
using UnityEngine.UI;

namespace DailyLogins
{
    public class DailyLoginButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        private CommandBus commandBus;
        
        private void Awake()
        {
            this.button.onClick.AddListener(ClickHandler);
        }

        private async void ClickHandler()
        {
            await this.commandBus.Execute(new ShowRewardPanel());
        }
    }
}