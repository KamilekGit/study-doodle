
import React from 'react'
import ava_min from '../../../../img/elon_mini.jpg'
function Post(props){
    return(
    <div className='post'>
        <img src={ava_min}alt='profile mini photo' />
        <span>Elon Mask</span>
        <p>{props.message}</p>
        <span className="likes">{props.likes} likes</span>
    </div>

    )
}
export default Post