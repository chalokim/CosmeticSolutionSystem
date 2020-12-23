화장품 판매점의 재무 현황과 매출 현황을 차트로 출력하는 매출 관리 시스템을 구현하였습니다.
## 개발기간
2020년 12월 14일 ~ 12월 18일

# 개발 환경





### C# Cosmetic Solution Client project
Microsoft Visual Studio Community 2019 v16.8.2

#### 언어
- C# 8.0

#### 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

#### 라이브러리
DevExpress Chart Control v.20.2.2

#### 데이터베이스
Microsoft MS-SQL Server 2019

## 화면 목록
1. 손익 계산서 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/1.%20%EC%86%90%EC%9D%B5%20%EA%B3%84%EC%82%B0%EC%84%9C%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 손익 계산서 버튼을 누르면 DB에 저장되어있는 손익계산서 내역 중 매출액, 영업이익, 당기순이익이 연도별로 차트로 표시되며 전체 내역은 표로 표시된다.

2. 재무 상태표 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/2.%20%EC%9E%AC%EB%AC%B4%20%EC%83%81%ED%83%9C%ED%91%9C%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 재무 상태표 버튼을 누르면 DB에 저장되어있는 재무상태표 내역(자산, 부채, 자본)이 연도별로 각각 차트 및 표로 표시된다.


3. 일/월별 판매량 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/3.%20%EC%9D%BC%EB%B3%84%20%EC%9B%94%EB%B3%84%20%ED%8C%90%EB%A7%A4%EB%9F%89%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 일별, 월별 제품 판매량을 모두 합산한 데이터, 카테고리별로 구분하여 합산한 데이터를 Stacked Bar 차트 형태로 출력한다


4. 시간대별 고객 구매자 수 분석 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/4.%20%EC%8B%9C%EA%B0%84%EB%8C%80%EB%B3%84%20%EA%B5%AC%EB%A7%A4%EC%9E%90%EC%88%98%20%EB%B6%84%EC%84%9D%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 12시부터 24시까지 나누어서 방문한 고객에 수를 보여준다. 
- DateEdit 버튼을 눌러서 해당 년도(2018년부터 2020년까지)를 선택하면, 방문한 고객수를 볼수가 있다.


5. 코로나 확진자 수에 따른 카테고리별 판매량 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/5.%20%EC%BD%94%EB%A1%9C%EB%82%98%20%ED%99%95%EC%A7%84%EC%9E%90%20%EC%88%98%EC%97%90%20%EB%94%B0%EB%A5%B8%20%EC%B9%B4%ED%85%8C%EA%B3%A0%EB%A6%AC%EB%B3%84%20%ED%8C%90%EB%A7%A4%EB%9F%89.jpg" width="80%">


6. 카테고리, 연령, 성별 매출 비중 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/6.%20%EC%B9%B4%ED%85%8C%EA%B3%A0%EB%A6%AC%EB%B3%84%20%EC%97%B0%EB%A0%B9%EB%8C%80%EB%B3%84%20%EB%B9%84%EC%A4%91%20%EB%82%A8%EC%9E%90%20-%20%EC%97%AC%EC%9E%90%20%ED%99%94%EB%A9%B4.jpg" width="80%">


7. 비건 화장품 매출 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/7.%20%EB%B9%84%EA%B1%B4%20%ED%99%94%EC%9E%A5%ED%92%88%20%EB%A7%A4%EC%B6%9C%20%ED%99%94%EB%A9%B4.jpg" width="80%">
- Brand 테이블에서 BrandTag=0인 브랜드들의 매출을 Sales 테이블에서 최근 3년만 연도별로 그룹화하여 SalesLine 테이블에서 각 연도별 수량을 더해 차트 구현. 


8. 브랜드별 최근 1년, 월 매출 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/8.%20%EB%B8%8C%EB%9E%9C%EB%93%9C%EB%B3%84%20%EC%B5%9C%EA%B7%BC%201%EB%85%84%20%EC%9B%94%20%EB%A7%A4%EC%B6%9C%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 브랜드별로 나누어 해당 년도에 매출을 보여준다.
- DateEdit 버튼을 눌러서 해당 년도(2018년부터 2020년까지)를 선택하면, 브랜드별로 나누어 해당년도 매출을 볼수가 있다.


9. Top 5 제품 화면
<img src="https://github.com/SieonLee/CosmeticSolutionSystem/blob/master/Document/9.%20Top%205%20%EC%A0%9C%ED%92%88%20%ED%99%94%EB%A9%B4.jpg" width="80%">

- 년, 월 기간동안 판매된 제품 중 상위 5개 제품을 데이터를 Doughnut 차트 형태로 출력한다.
