import React from "react";
import Post from "./post/Post.js";
function Posts(){
    return(
        <div className="posts">
        <input placeholder="enter the post"></input>
        <button>Add post</button>
        <Post message="Hi, world"/>
        <Post message="i'm Elon Mask, really"/>
        <Post message="Give me some bitcoin"/>
        </div>
    )
}
export default Posts