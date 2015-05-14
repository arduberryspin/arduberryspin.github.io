출처 - http://kocoafab.cc/tutorial/view/356http://kocoafab.cc/tutorial/view/356
/*
 제목		: 조도센서로 어두워지면 LED 켜기
 내용		: 조도센서를 손으로 가려 어둡게 만들면 LED가 켜지도록 해봅시다.
 */

// 조도센서는 빛의 밝기에 대하여 전기저인 성질로 변환시켜주는 센서입니다.
// 조도센서를 아날로그 A1핀으로 설정합니다.
int cds = A1;
// LED를 A0핀으로 설정합니다.
int led = A0;

// 실행시 가장 먼저 호출되는 함수이며, 최초 1회만 실행됩니다.
// 변수를 선언하거나 초기화를 위한 코드를 포함합니다.
void setup() {
  // 조도센서의 동작 상태를 확인하기 위하여 시리얼 통신을 설정합니다. (전송속도 9600bps)
  // 메뉴 Tool -> Serial Monitor 클릭
  Serial.begin(9600);
  // LED 핀을 OUTPUT으로 설정합니다.
  pinMode(led, OUTPUT);
}

// setup() 함수가 호출된 이후, loop() 함수가 호출되며,
// 블록 안의 코드를 무한히 반복 실행됩니다.
void loop() {
  // 조도센서로 부터 측정된 밝기 값을 읽습니다.
  // 조도센서로 부터 입력되어지는 전압의 크기 (0~5V)에 따라 0~1023 범위의 값으로 변환되어 반환합니다.
  int cdsValue = analogRead(cds) / 10 - 20;

  // 측정된 밝기 값를 시리얼 모니터에 출력합니다.
  Serial.print("cds =  ");
  Serial.println(cdsValue);

  // 조도센서로 부터 측정된 밝기 값이 50보다 크다면, 아래의 블록을 실행합니다.
  if (cdsValue > 50) {
    // LED가 연결된 핀의 로직레벨을 HIGH (5V)로 설정하여, LED가 켜지도록 합니다.
    digitalWrite(led, HIGH);
    // LED상태를 시리얼 모니터에 출력합니다.
    Serial.println("LED ON (cds > 50)");
  }
  // 조도센서로 부터 측정된 밝기 값이 50보다 작면, 아래의 블록을 실행합니다.
  else {
    // LED가 연결된 핀의 로직레벨을 LOW (0V)로 설정하여, LED가 꺼지도록 합니다.
    digitalWrite(led, LOW);
    // LED상태를 시리얼 모니터에 출력합니다.
    Serial.println("LED ON (cds < 50)");
  }
  // 0.2초 동안 대기합니다.
  delay(200);
}
