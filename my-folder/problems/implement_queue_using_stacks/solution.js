var MyQueue = function() {
  this.first = [];
  this.last = [];
};

/** 
 * @param {number} x
 * @return {void}
 */
MyQueue.prototype.push = function(x) {
const len = this.last.length;
  for (let i = 0; i < len; i++) {
    this.first.push(this.last.pop());
  }
  this.first.push(x);
};

/**
 * @return {number}
 */
MyQueue.prototype.pop = function() {
const len = this.first.length;
  for (let i = 0; i < len; i++) {
    this.last.push(this.first.pop());
  }
  if (this.last.length) {
    return this.last.pop();
  }
  return undefined;
};

/**
 * @return {number}
 */
MyQueue.prototype.peek = function() {
  if (this.last.length) {
    return this.last[this.last.length-1];
  } else if(this.first.length) {
    return this.first[0];
  }
  return undefined;
};

/**
 * @return {boolean}
 */
MyQueue.prototype.empty = function() {
  if (this.last.length + this.first.length) {
    return false;
  }
  return true;
};

/** 
 * Your MyQueue object will be instantiated and called as such:
 * var obj = new MyQueue()
 * obj.push(x)
 * var param_2 = obj.pop()
 * var param_3 = obj.peek()
 * var param_4 = obj.empty()
 */