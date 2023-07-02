$(document).ready(function() {
  var counterElement = $('#counter');

  function animateCountUp(targetCount) {
    var currentCount = 0;
    var increment = Math.ceil(targetCount / 100); // 每次增加的數量

    var timer = setInterval(function() {
      if (currentCount < targetCount) {
        currentCount += increment;
        if (currentCount > targetCount) {
          currentCount = targetCount;
        }
        counterElement.text(currentCount);
      } else {
        clearInterval(timer);
      }
    }, 10);
  }

  // 獲取存儲在本地存儲中的造訪人數，如果不存在，則設置為0
  var count = parseInt(localStorage.getItem('counter')) || 0;

  // 更新造訪人數
  counterElement.text(count);

  // 增加造訪人數並將其保存在本地存儲中
  count++;
  localStorage.setItem('counter', count);

  // 開始數字增加的動畫
  animateCountUp(count);
});
