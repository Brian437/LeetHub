/**
 * // Definition for a Node.
 * function Node(val, left, right, next) {
 *    this.val = val === undefined ? null : val;
 *    this.left = left === undefined ? null : left;
 *    this.right = right === undefined ? null : right;
 *    this.next = next === undefined ? null : next;
 * };
 */

/**
 * @param {Node} root
 * @return {Node}
 */
var connect = function(root) {
    
    let node=root;
    let listLevel=[];
    addToList(root,0);
    
    function addToList(node,level)
    {
        if(listLevel[level]==undefined)
        {
            listLevel[level]=[];
        }
        listLevel[level].push(node);
        
        if(node !=null && node.left!=null)
        {
            addToList(node.left,level+1);
            addToList(node.right,level+1);
        }
    }
    
    
    
    for(let i=0;i<listLevel.length;i++)
    {
        for(let j=0;j<listLevel[i].length-1;j++)
        {
            listLevel[i][j].next=listLevel[i][j+1];
        }
        listLevel[i][listLevel[i].length-1]=null;
    }
    
    return root;
};
