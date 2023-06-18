import React from "react";
import Post from "../profile/posts/post/Post";
import Mess from "./dialog";
function Dialogs(){
    return(
        <div className="dialogs">
        
        <Post message="Hi, world"/>
        <Post message="Microsoft"/>
        <Post message="Give me some bitcoin"/>
        <input placeholder="message"></input>
        <button>Add message</button>
        </div>
    )
}
export default Dialogs