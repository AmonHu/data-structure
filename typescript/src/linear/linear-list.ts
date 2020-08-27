export interface LinearList<T> {
    /**
     * initialize the list
     */
    initList(): void;

    /**
     * destroy the list
     */
    destroyList(): void;

    /**
     * clear the list
     */
    clearList(): void;

    /**
     * return is the list empty
     */
    isEmpty(): boolean;

    /**
     * return the list length
     */
    getLength(): number;

    /**
     * get element by index
     * @param index 索引
     */
    getElement(index:number): T;

    /**
     * find element 'e' with function compare
     * @param e the element
     * @param compare the compare function
     */
    findElement(e: T, compare: (a: T, b: T) => boolean): number;
}