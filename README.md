# Unity_3D_Game_Infinity

## INFINITY made with Unity

### 1. [게임 방식]
- 비행기로 운석을 피하고 별(보석)을 모으며 달러 코인을 쌓음
- 홈에서 달러 코인으로 새로운 우주선 구매하여 레벨 업
- 한 레벨 업그레이드에 별이 하나씩 늘어나며 별의 단위 코인과 
- 한 번 비행으로 모을 수 있는 별 개수 증가
- 일정 개수의 별을 다 모으면 AWESOME FLIGHT
- 운석에 부딪히거나 타임아웃(3분) 되면 GAME OVER

<img width="1440" alt="스크린샷 2019-06-13 오전 2 41 25" src="https://user-images.githubusercontent.com/38905066/119701715-a69f7180-be8f-11eb-9923-dd570319aeb6.png">

### 2. Control
### MouseCrossHair
 : 사용자가 조종하는 십자 모양 핸들러

### FixedCrosshair 
: 십자가의 기준 범위,
원을 벗어나는 정도로 
비행기 방향 조종

### 조이스틱(Joystick)
 : Pitch/Yaw로 상하좌우 조절

Pitch - Down/Up (상하)
Yaw - Left/Right(좌우)

### Linear & Angular Force
: X,Y,Z방향으로 가해지는 Force 크기 조절
=> 비행 속도(Speed) 100~142

Reference : https://github.com/brihernandez/ArcadeSpaceFlightExample

### 3. Level : LV.1부터 LV.8까지
30 > 70 > 120 > 180 
> 240 > 300 > 350 > 400 
레벨에 추가된 보석들, 하나당 모아지는 달러 코인 수 증가!

### 4. Assets

### 8 Levels, Different Airplanes
+ 프로펠러 애니메이션
+ “hover” 프로펠러 소리

### Gems(별, 보석)
: RandomAreaSpawner
레벨 올라갈수록 더 넓은 Range에 적은 개수의 Gems 생성 (10단위)

### Asteroids
: RandomAreaSpawner
500 Range에 30개씩 생성

### Gas Planets
: RandomAreaSpawner으로 1000 Range에 12개씩 랜덤하게 생성 
Galaxy & Supernova
: RandomAreaSpawner으로 
Galaxy는 800 Range에 20개씩
Supernova는 800 Range에 10개씩 랜덤하게 생성

### 5. Sound Track
홈화면 배경음악 : happy_light_loop
게임 배경음악  :  Starship_Briefing_[Free_Loop]
비행기 프로펠러 소리 : hover
별(보석) 먹을 때 효과음 :  Score_swap_2_b
운석 부딪힐 때 효과음 : Blow Distance

## 6. Play Scene Capture Images

<img width="1274" alt="스크린샷 2019-06-13 오전 3 59 34" src="https://user-images.githubusercontent.com/38905066/119701800-b9b24180-be8f-11eb-97ef-06df81104334.png">
<img width="1440" alt="스크린샷 2019-06-13 오전 3 17 20" src="https://user-images.githubusercontent.com/38905066/119701810-bcad3200-be8f-11eb-9362-f1967706d4a6.png">
<img width="1440" alt="스크린샷 2019-06-13 오전 3 15 47" src="https://user-images.githubusercontent.com/38905066/119701815-bf0f8c00-be8f-11eb-8ec8-c19ef99a4a66.png">
<img width="1440" alt="스크린샷 2019-06-13 오전 3 15 25" src="https://user-images.githubusercontent.com/38905066/119701829-c171e600-be8f-11eb-8b84-330076385700.png">
<img width="937" alt="스크린샷 2019-06-13 오전 1 04 58" src="https://user-images.githubusercontent.com/38905066/119701883-ce8ed500-be8f-11eb-9d69-2772495bf3dc.png">
<img width="928" alt="스크린샷 2019-06-13 오전 1 05 30" src="https://user-images.githubusercontent.com/38905066/119701896-d3538900-be8f-11eb-9cf8-6982d3b5c460.png">
<img width="967" alt="스크린샷 2019-06-13 오전 1 41 27" src="https://user-images.githubusercontent.com/38905066/119701926-d9496a00-be8f-11eb-9fe0-2ff3413d517d.png">

