using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IRobot
    {
        // 인터페이스의 구성 요소는 모두 public
        // 자동 구현 프로퍼티가 아님
        // 구현할 프로퍼티를 뜻함
        int BatteryLevel { get; set; }
        
        void Charger();
    }
}
