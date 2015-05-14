// 예제 23-1 아두이노

// 버퍼의 길이
const int BUFFER_LENGTH = 5;

// 버퍼 중앙의 인덱스
const int INDEX_OF_MIDDLE = BUFFER_LENGTH / 2;

// 버퍼
int buffer[BUFFER_LENGTH];

// 버퍼에 데이터를 써넣는 인덱스
int index = 0;

// 센서에 연결한 아날로그 핀의 번호
const int sensorPin = A1;

void setup() {
  // 결과를 출력하기 위한 시리얼을 시작
  Serial.begin(9600);
}

void loop() {
  // 센서의 값을 읽어 들인다
  int raw = analogRead(sensorPin);
  
  // 읽어 들인 값을 버퍼에 써 넣는다
  buffer[index] = raw;

  // 다음 버퍼에서 써 넣을 위치를 새로 고침
  // 버퍼의 맨 마지막까지 오면 되풀이한다
  index = (index + 1) % BUFFER_LENGTH;

  // Mean 필터와 Median 필터로 각각을 스무딩 처리
  int smoothedByMeanFilter = smoothByMeanFilter();
  int smoothedByMedianFilter = smoothByMedianFilter();

  // 결과를 시리얼로 출력
  Serial.print(raw);
  Serial.print("\t");
  Serial.print(smoothedByMeanFilter);
  Serial.print("\t");
  Serial.print(smoothedByMedianFilter);
  Serial.println();

  // 다음의 루프 시작까지 100ms 대기
  delay(100);
}

// Mean 필터로 스무딩 처리
int smoothByMeanFilter() {
  // 버퍼의 값의 합계를 집계하기 위한 변수
  long sum = 0;
  
  // 버퍼의 값의 합계를 구함
  for (int i = 0; i < BUFFER_LENGTH; i++) {
    sum += buffer[i];
  }

  // 평균을 필터의 출력 결과로 돌려준다
  return (int)(sum / BUFFER_LENGTH);
}

// Median 필터로 스무딩 처리
int smoothByMedianFilter() {
  // 정렬에 사용하는 버퍼
  static int sortBuffer[BUFFER_LENGTH];
  
  // 정렬에 사용하는 버퍼에 데이터를 복사
  for (int i = 0; i < BUFFER_LENGTH; i++) {
    sortBuffer[i] = buffer[i];
  }
  
  // 퀵소트 정렬 방밥으로 순서를 바꾼다
  // 인수는 버퍼, 요소의 수, 요소의 크기, 비교용 메서드
  qsort(sortBuffer, BUFFER_LENGTH, sizeof(int), comparisonFunction);

  // 정렬 결과의 중앙값을 출력 결과로 돌려준다
  return sortBuffer[INDEX_OF_MIDDLE];
}

// 퀵소트로 사용하는 비교용 메서드
int comparisonFunction(const void *a, const void *b) {
  // void형을 int형으로 캐스트
  int _a = *(int *)a;
  int _b = *(int *)b;
  
  if (_a < _b) {
    // a＜b 이면 -1을 돌려준다
    return -1;
  } else if (_a > _b) {
    // a＞b 이면 1을 돌려준다
    return 1;
  } else {
    // 둘 다 아니라면(즉 a = b) 0을 돌려준다
    return 0;
  }
}
