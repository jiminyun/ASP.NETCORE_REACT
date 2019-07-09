import React, {useState} from 'react';
import "./tour.scss";
import london from './london.jpeg' 
const Tour = props => {
  const { name, description, imagePath, info, pointsOfInterest } = props.tour;
  
  const [isShowInfo, toggleShowInfo] = useState(false);
  return (
    <article className="tour">
      <div className="img-container">
        <img src={imagePath} alt="city tour" />
        <span className="close-btn">
          <i className="fas fa-window-close" />
        </span>
      </div>
      <div className="tour-info">
        <h3>{name}</h3>
        <h5>
         {description} <br /><br />
        </h5>
        <h3>PointsOfInterest</h3>
        <div>
          {pointsOfInterest.map(po => 
            (<h5>-{po.name} <br />{po.description}</h5>))}
        </div>
        <h3>
        <br />info{" "}
            <span onClick={() => toggleShowInfo(!isShowInfo)}>
              <i className="fas fa-caret-square-down" />
            </span>
        </h3>
        {isShowInfo && <p>{info}</p>}
      </div>
    </article>
  );
}

export default Tour;