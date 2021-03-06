namespace Protogame
{
    using Protoinject;

    /// <summary>
    /// The game asset manager provider.
    /// </summary>
    public class GameAssetManagerProvider : IAssetManagerProvider
    {
        /// <summary>
        /// The m_ asset manager.
        /// </summary>
        private readonly LocalAssetManager m_AssetManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameAssetManagerProvider"/> class.
        /// </summary>
        /// <param name="kernel">
        /// The kernel.
        /// </param>
        /// <param name="profilers">
        /// The profilers.
        /// </param>
        /// <param name="rawLoader">
        /// The raw loader.
        /// </param>
        /// <param name="rawSaver">
        /// The raw saver.
        /// </param>
        /// <param name="loaders">
        /// The loaders.
        /// </param>
        /// <param name="savers">
        /// The savers.
        /// </param>
        /// <param name="transparentAssetCompiler">
        /// The transparent asset compiler.
        /// </param>
        public GameAssetManagerProvider(
            IKernel kernel, 
            IProfiler[] profilers, 
            IRawAssetLoader rawLoader, 
            IRawAssetSaver rawSaver, 
            IAssetLoader[] loaders, 
            IAssetSaver[] savers, 
            ITransparentAssetCompiler transparentAssetCompiler)
        {
            this.m_AssetManager = new LocalAssetManager(
                kernel, 
                profilers, 
                rawLoader, 
                rawSaver, 
                loaders, 
                savers, 
                transparentAssetCompiler);
        }

        /// <summary>
        /// Gets a value indicating whether is ready.
        /// </summary>
        /// <value>
        /// The is ready.
        /// </value>
        public bool IsReady
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// The get asset manager.
        /// </summary>
        /// <param name="permitCreate">
        /// The permit create.
        /// </param>
        /// <returns>
        /// The <see cref="IAssetManager"/>.
        /// </returns>
        public IAssetManager GetAssetManager(bool permitCreate)
        {
            return this.m_AssetManager;
        }
    }
}