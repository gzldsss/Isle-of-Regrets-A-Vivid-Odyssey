# Isle-of-Regrets-A-Vivid-Odyssey
A record of a game.
## Concept
This narrative presents a tale of letting go and rebirth. I developed an experimental game using Unity, focusing on the study of the relationship between sound and immersion. Integrating findings from prior research, the game leverages auditory elements to enhance player engagement and immersion.
The game employs an abstract narrative approach to dissect the story of a girl burdened by a high-pressure childhood, exploring her journey towards reconciling with her past. I collected numerous childhood regrets from friends, incorporating these as pivotal elements within the game. The sources of pressure depicted are multifaceted, stemming not only from familial environments, marked by high parental expectations, strict discipline, and emotional traumas, but also from educational settings characterized by flawed teaching methods and a severe lack of freedom. These factors collectively shape the childhood and adolescent experiences of many children in China.
Players assume the role of an observer, delving deep into the protagonist’s inner world. This realm is rich in symbolic significance, visually presenting dreamlike, beautiful scenes, yet simultaneously conveying an atmosphere of repression and solitude. Through interaction with objects in the environment, players gain insights into the protagonist's psyche.
## Scene building, scripting and game running
There is a huge landscape in the game scene, and this landscape is the inner world of the protagonist. I used the terrain tool to build it and covered a patch of water, creating islands with jutting terrain.

![15](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/f4dc58e3-402d-46fb-a4ad-b27d07d46314)

The terrain is characterized by a silver matte finish, while the water surface is sourced from Unity Asset Store's #NVJOB Water Shaders V2. This selection includes a flowing and reflective transparent water surface, enhancing the ocean's realism. Additionally, I employed a Skybox visual effect that merges orange and blue-green hues, aiming to imbue a dreamlike, childlike effect and to distinguish it from the real world.

<img width="797" alt="10" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/fcf3e4e5-7c8c-45d3-9c7f-94d016db4f32">

I employed an Xbox Controller as the medium for players to interact with the game, facilitating a first-person gaming experience. To integrate the Xbox Controller with Unity, I utilized the new Input System. I created a new Input Action to assign specific actions to the Xbox Controller, binding movements to the left and right joysticks. The left joystick controls player movement, while the right joystick is responsible for camera rotation. And by adding scripts, a scoring 3D first-person player character controller in the Unity environment was implemented.

<img width="555" alt="09" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/777f91fc-8d43-4d52-a1db-1f769b9771a9">

The script includes effects that control player movement, camera sensitivity, gravity, and camera bumps, enhancing realism and immersion.
Background music was incorporated into the game, derived from the instrumental version of Song X, wherein the first ten seconds of the accompaniment are looped for playback. This choice was influenced by the game's initial narrative, which is tinged with a sense of melancholy. Additionally, given the game's comparatively tranquil setting, the background music was selected for its calm and soothing qualities.

<img width="707" alt="20" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/33a196bd-b14f-455a-9e68-2975691971f6">

In the environment, I integrated a particle system wherein the density and quantity of particles fluctuate in response to the background music.
This effect synergistically integrates visual and auditory elements with the aim of engendering in players a sensation of genuine immersion within the scene. This enhancement of immersion is intended to foster deeper player engagplify the conveyance and reception of emotional nuances. Additionally, it facilitates the transmission of the background music's themes of solitude and sorrow.

<img width="675" alt="19" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/43a470ae-2c75-4040-9a39-6674a65f477a">

Initially, the system controls the emission frequency of particles by acquiring audio data and computing the frequency distribution of the audio signal. The intensity of the audio is multiplied by 5000 to determine the emission rate for the particle system. Subsequently, this calculated emission rate is applied to the emission module of the particle system, thereby establishing a direct proportionality between the particle emission rate and the audio intensity. The higher this value, the more pronounced the variation in particle behavior. Consequently, at peaks of musical frequency, the density of particles in the sky increases, becoming more concentrated, while a decrease in musical frequency results in a corresponding reduction in the density of particles. This dynamic adjustment creates a visual representation that is in harmony with the auditory experience. 

![23](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/3dfa995e-d100-4333-86d5-f82f08c631aa)

The variation in particles is depicted in the accompanying figure. Considering factors such as the computational capabilities of the computer and the soothing nature of the music, the changes in particle behavior before and after are not excessively pronounced. This moderation in particle dynamics is a deliberate design choice, taking into account the need to balance visual impact with system performance and the ambient quality of the audio.

![12](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/328cb886-a1f9-49f0-bac3-06311e03d9c0)

I have imported a goldfish model equipped with skeletal animation, setting the animation to loop indefinitely, thus enabling the goldfish to exhibit continuous motion.
To enhance the model, dynamic materials were added to the goldfish. The shader for these materials was sourced from PeterLu_HologramShader, available on the Unity Asset Store, which contributes to a dreamlike visual effect. Additionally, 3D audio was integrated into the goldfish model. Consequently, as players approach the goldfish, they will hear the sound of bubbles being emitted, further augmenting the immersion and realism of the experience.

<img width="687" alt="14" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/d104ea9c-7833-4685-9741-745eb5b4fa15">

An empty object, named 'Waypoint', was created and strategically placed within the scene to designate the movement targets for the goldfish. Each goldfish is assigned three distinct Waypoints, differentiated by a sequential numbering system. A script is utilized to control the movement of the goldfish, ensuring they sequentially navigate through all the predetermined Waypoints. This setup allows the goldfish to continuously move and exhibit their motion animations. As a result, the goldfish appear to swim through the sky, adding a dynamic and visually intriguing element to the scene.

![41](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/6c5ef2a7-d759-46ec-ae9e-456828c4b23f)

In the scene, an abundance of mushrooms and marine plants have been incorporated. The mushrooms symbolize illusions, representing the protagonist's inner world, akin to a dreamlike state. In contrast, the marine plants signify the area where the protagonist resided during their childhood. These two types of flora constitute critical components of the scene's composition.

![34](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/87f1e820-3ff6-4da3-84f0-cab98fb28c19)
![35](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/4a08f709-483d-4f92-920d-ce53accdfbf4)
![33](https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/409bf8a4-69d6-4710-bacd-b3f7dd93220d)

In the scene, certain marine plants emit a tinnitus-like sound when the player approaches, causing the corals to appear as a jumble of incomprehensible code. The sound of tinnitus often brings an uncomfortable sensation, occasionally leading to emotional fluctuations, including feelings of depression and pessimism. Some individuals experience headaches and earaches concurrent with tinnitus. I utilized the sound of tinnitus to represent internal stress and suppression. The effect was achieved primarily by adding collision volumes to the plants and implementing it through scripting.

<img width="574" alt="37" src="https://github.com/gzldsss/Isle-of-Regrets-A-Vivid-Odyssey/assets/118484191/bd3702b1-1270-4b96-b5e3-9e1daf06dbd5">

Initially, collision volumes are added to the plants with precise settings for the center point and dimensions. The script, as illustrated, activates when the player nears the plants within a predefined distance, triggering a change in the plants' texture and initiating sound playback. Once the player departs from this trigger zone, the plants revert to their original texture, and the sound playback ceases. Subsequent adjustments are made to the trigger radius to facilitate seamless player entry into this range. Additionally, the modified textures and corresponding sounds are incorporated to ensure the script functions effectively.








