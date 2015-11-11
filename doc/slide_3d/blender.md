name: inverse
layout: true
---
class: title, center, middle

unity blender ros
# <span class="sky">3D</span> modeling

.footnote[
- http://arduberryspin.github.io/
- [발표자](https://www.facebook.com/kozazz): 곽두환
]

---
class: middle, full-text

# 들어가기에 앞서
-  Blender 3D Basics 교재를 준비합니다. [링크](http://it-ebooks.info/book/4735/)
-  example code 를 다운로드 합니다. 107M  [링크](https://drive.google.com/open?id=0Bx2HRnvXDiZ5ekZLcXA3UmxEcTQ)

---
class: middle, full-text

![](/doc/slide/img/fromto.jpg)

---
class: middle, full-text

# 개요
-  현재 위치는? 어디에 있는가?
- 왜? 유니티
- 왜? 블랜더
- 3d print
- blender 4장~ 끝까지
- 가상현실(VR, Virtual Reality)

---
class: middle, full-text

# 왜? 유니티
- 웹서비스 브라우저의 한계, 높아지는 눈높이
- 화면개발이 많다.
- 네똥기 안드로이드게임 ![](/doc/slide/img/ndgi.png)
- 유니티!

---
class: middle, full-text

# 유니티..
- 유니티 배치 구성 20 / 개발 40 / 모델 40
- 게임 엔진이 화면을 훌륭하게 지원
- 역시 모델

---
class: middle, full-text

# 아두베리탱크
<iframe width="420" height="315" src="https://www.youtube.com/embed/CuccsuyVhTM" frameborder="0" allowfullscreen></iframe>
- 네트워크 게임도 쉽게!
- 20명 동접 가능 게임
- 1 소스 , 멀티 플렛폼 생산
- 아두베리탱크 android [링크](https://play.google.com/store/apps/details?id=com.dubu.unity.tank)
- 아두베리탱크 web [링크](http://arduberryspin.github.io/doc/part4/unity/tank_web.html)
- 게임 한 판~

---
class: middle, full-text

# 왜? 3D 모델- 블렌더
- 모델을 중요.
- 사실 3D 프린터로 먼저 접근
- 메이커 본능. 금속/레이저컷/3D프린터
- 의수 등 많이 많듭니다.
- 의외로 쓸만한 모델이 없다.

---
class: middle, full-text

# 3D 모델
- thingiverse [링크](thingiverse.com) shapeways [링크](http://www.shapeways.com/) makersn [링크](http://makersn.com)
- 모델링 대회 수상작 참고 makersn [링크](http://makersn.com)
- 다른 사람들은 무엇을 만들고 있는가

---
class: middle, full-text

# 3D 모델
- 처음부터 만들지 않습니다.
- 좋은 모델을 뽑다가 보니, 더 뽑을 모델이 없다.
- 쬐금 고치고 싶은데
- 포토샵을 하면 좋듯이, 3D 모델링 할줄 알면 좋습니다.

---
class: middle, full-text

# 3D 모델링의 예

- 유니티게임에도
- ros 로봇에도
- 피규어 [링크](http://3d.daara.co.kr/bbs/util_view.php?idx=341)
- 실물크기 코끼리 <iframe width="560" height="315" src="https://www.youtube.com/embed/PJfwfI9xq24" frameborder="0" allowfullscreen></iframe>

---
class: middle, full-text

# 3D 모델링의 예  - 지형
- 국립현대미술관 북한산 ![](/doc/slide/img/hy_mo.jpg)
- 판교  ![](/doc/slide/img/mou.jpg)
- height map을 이용한 지형생성 [링크](https://www.facebook.com/groups/arduberryspin/permalink/656550147818292/)

---

# 3D 모델링의 예  - 지형

![](/doc/slide/img/pangyoHeightMap.png)

1. height이미지  http://terrain.party/
2. 포토샵 적절히 가공
3. 유니티 terrain 생성 및 export obj
4. 블렌더 obj 가공

---

# 3D 프린팅

![](/doc/slide/img/blender_mk.png)

![](/doc/slide/img/mk.jpg)

---
class: middle, full-text

# 3D 모델링 - 블렌더 4장부터 끝까지
<iframe width="560" height="315" src="https://www.youtube.com/embed/qO5yBEHwJ54" frameborder="0" allowfullscreen></iframe>

---
class: middle, full-text

# 블렌더 맨 뒷장
- 시간이 없으니 최종 완성본 부터
- 모델등의 종합
- 아일랜드 [링크](https://www.facebook.com/groups/arduberryspin/permalink/655957241210916/)

---
class: middle, full-text

# 블렌더 4장부터 끝까지
- 책은 Blender 3D Basics
- 예제파일 [링크1](https://www.packtpub.com/books/content/support/10092)
- 예제파일 100M [구글드라이브](https://drive.google.com/open?id=0Bx2HRnvXDiZ5ekZLcXA3UmxEcTQ)
- 이제 진도를 나가 봅시다.

---
class: middle, full-text

# 블렌더 요약
- 맨뒤>4장
- 네모난 배
- 면이 많은 배
- 핸들/노/잡다부리
- 지형
- 애니메이션

---
class: middle, full-text

# vr

- 핸드폰의 해상도 한계
- 평면 디스플레이어의 3D
- 오큘러스
- 모델/ 컨텐츠의 부족

---
class: middle, full-text

# vr
https://www.youtube.com/watch?v=vq_R4qDz_wo
<iframe width="420" height="315" src="https://www.youtube.com/embed/vq_R4qDz_wo" frameborder="0" allowfullscreen></iframe>

- 아두베리vr [링크](https://www.facebook.com/groups/arduberryspin/permalink/653959388077368/)

---
class: middle, full-text

![](/doc/slide/img/fromto.jpg)

감사합니다

