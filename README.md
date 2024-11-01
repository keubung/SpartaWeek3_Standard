# SpartaWeek3_Standard
 
- 1. 입문 주차와 비교해서 입력 받는 방식의 차이와 공통점을 비교해보세요.
- 2. CharacterManager와 Player의 역할에 대해 고민해보세요.
<br> CharacterManager.cs: 플레이어의 정보를 관리한다.
<br> Player.cs: 플레이어에게 정보를 준다?
- 3. 핵심 로직을 분석해보세요 (`Move`, `CameraLook`, `IsGrounded`)
<br> Move: 현재 방향과 입력 값을 받아와서 입력한 속도로 움직인다.
<br> CameraLook:
<br> IsGrounded: 
- 4. `Move`와 `CameraLook` 함수를 각각 `FixedUpdate`, `LateUpdate`에서 호출하는 이유에 대해 생각해보세요.
  <br>FixedUpdate - Update - LastUpdate 순으로 업데이트 된다.
   <br>LastUpdate는 Update가 완전히 끝난 후 프레임 당 한 번 실행된다.
   <br>FixedUpdate는 물리적 움직임을 일정한 간격으로 호출한다.
   <br>따라서 FixedUpdate에서 이동을 하고 LateUpdate에서 그 위치에 맞는 카메라의 움직임을 준다.

---
**<프로젝트 설명>**
1. 설정
   - Tab으로 열고 닫기
   - 적용 버튼 미구현
   - 설정 옵션들 미구현
