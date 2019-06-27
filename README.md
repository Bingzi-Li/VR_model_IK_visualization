## Project Abstract
Rehabilitation of adhesive capsulitis of shoulder is a tedious and inconvenient process. The aim of the project is to design a Virtual Reality game to assist rehabilitation of adhesive capsulitis of shoulder. In that way, patients can do rehabilitation exercises at home with fascinating games, instead of going to hospital to do repetitive exercises. The game includes a game environment for active rehabilitation, and visualization of a humanoid model, and action recognition based on machine learning and CNN. 
One of the limitations of the current VR games is that they are usually in first person view. In VR rehabilitation, it is essential for players to monitor their actions and effect on their shoulders. My individual part of project intends to provide the players with real-time visualization of humanoid model and coloring to represent the stretching and contracting of real muscles.
The visualization includes three parts. The first part is display of the humanoid model. This is implemented by constructing a mirror using render texture approach and adding a script to grant user control of the displaying position and angle. The second part is real-time display of user’s actions, which is implemented by inverse kinematics. The last part is done by grouping the mesh of model by several parts, each is assigned different color, changing according to the angle and position of arm bones. In this way, we construct a display of humanoid model to provide real-time feedback to the patient who plays our game to gain rehabilitation.

#### Keywords: VR game, humanoid model visualization, rehabilitation, machine learning, CNN, action recognition
<hr>

### Partial Results:

###### result of render texture using VRTK simulator: 
![alt text](https://i.ibb.co/CJdhhX8/1.png "Mirror View")
###### Combined with camera moving script, the mirror can show every side of the model:
![alt text](https://i.ibb.co/DK38w07/2.png "Different Angles")

In our project, one of the goals is to represent the degree of strain on each muscle using different colours. We use red for high strain, blue for low strain. The colours change as the angle between the upper arm and forearm changes when the model is moving using inverse kinematics.As we can see in the image below, when the model’s arm is relaxing, the colour is nearly grey, the original colour. When the arm bends, the strained muscle will turn red and relaxed muscle will turn blue.

###### Arm Relaxing: 
![alt text](https://i.ibb.co/6m3ZswS/3.png "Arm Relaxing")
###### Arm Bending:
![alt text](https://i.ibb.co/kmQWDMQ/4.png "Arm Bending")
