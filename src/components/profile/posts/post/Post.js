import React from "react";
import ava_min from 'C:/Users/meysi/OneDrive/Рабочий стол/reactjs/project2/project2/src/components/profile/elon_mini.jpeg'
function Post(props){
    return(
        <div className="post">
            <img src={ava_min}/>
            
            
            
            <p>{props.message}</p>
        </div>
        
    )
}
export default Post