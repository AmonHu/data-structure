export interface Stack<T> {
    /**
     * 出栈
     */
    pop(): T | undefined;

    /**
     * 入栈
     * @param e element
     */
    push(e: T): void;

    /**
     * 获取栈顶元素
     */
    peek(): T|undefined;

    /**
     * 判断栈是否空
     */
    isEmpty(): boolean;

    /**
     * 清空栈
     */
    clear(): void;

    /**
     * 获取栈长度
     */
    size(): number;
}