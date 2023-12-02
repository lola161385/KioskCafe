# Cafe_Kiosk

## 😃 개요

[Cafe_Kiosk]는 . . .

- 대학 과제로 인해 제작하게 되었습니다.
- 디자인은 미적감각이 부족하여 꾸미지 못했습니다.
- 개인 공부 용도로 참고 하실분은 코드를 사용하셔도 좋습니다.
### ※ 상업적 용도로는 사용 불가함을 알려드립니다 ※

## 😅 공지
- 이미지는 (메가커피, 이디야, 공차, 스무디킹, 요거프레소, 구글 이미지)등 에서 스크린샷으로 첨부 되었습니다
- 비상업적 용도 임을 밝힙니다.(자세한 저작권 문제를 알고 계신분은 메일을 통해 알려주시면 감사하겠습니다.)

## ✍️ 주요 기능

### Form1
- 매장 / 포장 선택

### Form2
- 간편하게 이메일과 이름을 입력하면 가입할 수 있습니다.
1. 카테고리(커피, 스무디, 디저트)
2. 메뉴 카테고리별 12개(12x3 = 총 36개)
   - 메뉴 버튼 클릭시 토핑 선택화면 이동 Form3
4. 총 금액
5. 매장 / 포장 표시
   - Form1 처음 화면에서 선택한 값을 반영
7. 장바구니 List
   - 리스트를 그룹화하여 관리
8. 메뉴 빼기 버튼
   - 메뉴 선택후 삭제하면 토핑까지 모두 삭제
   - 토핑 선택후 삭제하면 선택 토핑만 삭제
9. 초기 화면 버튼
   - Form1 초기화면으로 이동
11. 결제 버튼
    - Form4 연결

<p align="left">
  <img src="https://github.com/lola161385/KioskCafe/assets/35729214/a7d94646-3ad7-46b0-b162-b46e0ae702e7">
</p>

### Form3 & Form5
#### Form3
- 토핑 선택 창의 이름은 선택된 메뉴의 이름이 표시됩니다.
- 토핑을 클릭하면 Form2의 총 금액 부분에 Plus됩니다.
- 닫기를 원한다면 Finish 버튼을 클릭
<p align="left">
  <img src="https://github.com/lola161385/KioskCafe/assets/35729214/659777c1-b791-4ef7-8d6a-8582a8b9d7d6">
</p>

#### Form5
- 토핑 선택 창의 이름은 선택된 메뉴의 이름이 표시 됩니다.
- 토핑을 클릭하면 Form2의 총 금액 부분에 Plus됩니다.
- 당도 선택은 radioButton으로 3가지중 한개만 선탣 될 수 있게 구현
- 아무것도 클릭하지 않을시 Finish버튼이 눌리지 않음
- 닫기를 원한다면 Finish 버튼을 클릭

<p align="left">
  <img src="https://github.com/lola161385/KioskCafe/assets/35729214/b3d4ac45-1987-49c6-aac8-ab3fc893f9ab">
</p>

### Form4
- 결제 창
  - 현금 결제
     - 
  - 카드 결제
  - 쿠폰 결제
<p align="left">
  <img src="https://github.com/lola161385/KioskCafe/assets/35729214/3e8cb647-d01e-4770-aced-5642c9dabbbf">
</p>

### 🖥 고객 주문 화면

- 고객은 손쉽게 자신이 원하는 상품을 고르고 주문할 수 있습니다.
- 결재는 카카오 페이로 손쉽게 가능합니다.

## 📀 프로젝트 기술스택

### 프론트 앤드

<img src="https://img.shields.io/badge/React-61DAFB?style=for-the-badge&logo=React&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=TypeScript&logoColor=white" />
<img src="https://img.shields.io/badge/React Query-FF4154?style=for-the-badge&logo=React Query&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/Recoil-1414A0?style=for-the-badge&logo=Recoil&logoColor=white" />
<img src="https://img.shields.io/badge/FramerMotion-0055FF?style=for-the-badge&logo=Framer&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/StyledComponents-DB7093?style=for-the-badge&logo=Framer&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/Code gen-FAFAFA?style=for-the-badge&logo=Code gen&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/GraphQL-E10098?style=for-the-badge&logo=GraphQL&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/ReactHookForm-DB7093?style=for-the-badge&logo=ReactHookForm&logoColor=white" />

### 백앤드

<img src="https://img.shields.io/badge/NestJS-E0234E?style=for-the-badge&logo=NestJS&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/TypeScript-3178C6?style=for-the-badge&logo=TypeScript&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/jwt-3178C6?style=for-the-badge&logo=jwt&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=MySQL&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/GraphQL-E10098?style=for-the-badge&logo=GraphQL&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/Node.js 16.x-339933?style=for-the-badge&logo=Node.js&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/typeorm-262627?style=for-the-badge&logo=typeorm&logoColor=white" />

### 형상관리

<img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=Git&logoColor=white">

### 인프라

<img src="https://img.shields.io/badge/Amazon EC2-FF9900?style=for-the-badge&logo=Amazon EC2&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/Amazon S3-569A31?style=for-the-badge&logo=Amazon S3&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/Ubuntu 20.x-E95420?style=for-the-badge&logo=Ubuntu&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/NGINX-009639?style=for-the-badge&logo=NGINX&logoColor=white" />&nbsp;<img src="https://img.shields.io/badge/GitHub Actions-2088FF?style=for-the-badge&logo=GitHub Actions&logoColor=white">

## 👨‍👩‍👧‍👧 누구나 키오스크 팀

|                                          Frontend                                          |                                          Frontend                                          |                                          Backend                                           |                                          Backend                                           |
| :----------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------------: |
| <img src="https://avatars.githubusercontent.com/u/44064122?v=4" width=400px alt="고현수"/> | <img src="https://avatars.githubusercontent.com/u/95143138?v=4" width=400px alt="조서연"/> | <img src="https://avatars.githubusercontent.com/u/39974627?v=4" width=400px alt="정선교"/> | <img src="https://avatars.githubusercontent.com/u/56436283?v=4" width=400px alt="조민수"/> |
|                            [고현수](https://github.com/movie42)                            |                            [조서연](https://github.com/sycho09)                            |                           [정선교](https://github.com/tjsry0466)                           |                          [조민수](https://github.com/minsoo0715)                           |

## 🕹 아키텍쳐

![아키텍쳐](https://user-images.githubusercontent.com/44064122/180215835-3dc96d91-f7cb-4638-ae55-4e851a4d481c.png)

## 🛠 CI/CD

![CICD](https://user-images.githubusercontent.com/44064122/180215824-6e7a9b14-f44f-493e-97c2-251092bb4769.png)
